using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class MyFile
    {
        public MyFile(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        private MyFile() { }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string FilePath { get; private set; }
        public long Size { get; private set; }

    }
}
