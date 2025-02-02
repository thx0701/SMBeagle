﻿using SMBeagle.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMBeagle.FileDiscovery.Output
{
    class FileOutput : IOutputPayload
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Username { get; set; }
        public string Hostname { get; set; }
        public string Directory { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastWriteTime { get; set; }
        public bool Readable { get; set; }
        public bool Writeable { get; set; }
        public bool Deletable { get; set; }
        public Enums.DirectoryTypeEnum DirectoryType { get; set; }
        public string Base { get; set; }
        public FileOutput(File file)
        {
            Name = file.Name.ToLower();
            Extension = file.Extension.TrimStart('.').ToLower();
            Directory = file.ParentDirectory.Path.ToLower();
            CreationTime = file.CreationTime;
            LastWriteTime = file.LastWriteTime;
            Readable = file.Readable;
            Writeable = file.Writeable;
            Deletable = file.Deletable;
            DirectoryType = file.ParentDirectory.Base.DirectoryType;
            Base = file.ParentDirectory.Base.Path;
        }
    }
}
