﻿using System;
using System.Collections.Generic;

namespace ItSynced.Web.DAL.Entities
{
    public class File : EntityWithId
    {
        public Directory ParentDirectory { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string DirectoryPath { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public virtual List<ModificationEntry> ModificationEntries { get; set; }
    }
}