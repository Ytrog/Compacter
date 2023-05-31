﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compacter
{
    internal class Compressor // TODO performance tune
    {
        private const string SCRIPT_PATH = "CompacterScript.cmd";

        public event EventHandler<string> ScriptCreated;

        public Compressor(FolderManager folderManager)
        {
            FolderManager = folderManager;
        }

        public FolderManager FolderManager { get; }

        private ImmutableArray<FileItem> GetCompressableFiles()
        {
            if (!(FolderManager.Initialized && FolderManager.Analyzed && FolderManager.FileItems != null))
            {
                throw new InvalidOperationException("Foldermanager not properly initialized");
            }

            return FolderManager.FileItems.Where(f => !(f.Compressed || f.Packed)).ToImmutableArray();
        }

        public void CreateScript()
        {
            ImmutableArray<FileItem> files = GetCompressableFiles();
            StringBuilder sb = new StringBuilder();

            foreach (FileItem file in files)
            {
                var extension = Path.GetExtension(file.Path);

                // determine if it is an executable
                if (extension.Equals("exe") || extension.Equals("dll"))
                {
                    sb.AppendLine($"compact /C /EXE:LZX {file.Path}");
                }
                else
                {
                    sb.AppendLine($"compact /C {file.Path}");
                }
            }

            string script = sb.ToString();

            File.WriteAllText(SCRIPT_PATH, script);

            EventHandler<string> raiseEvent = ScriptCreated; // temporary copy to prevent race conditions

            if (raiseEvent != null)
            {
                raiseEvent(this, Path.GetFullPath(SCRIPT_PATH)); // TODO is this needed?
            }
        }

        internal static void Compress(IWin32Window? owner)
        {
            ScriptReview scriptReview = new ScriptReview(Path.GetFullPath(SCRIPT_PATH));
            scriptReview.ShowDialog(owner);
        }
    }
}