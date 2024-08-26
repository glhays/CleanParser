// -------------------------------------------------------------------------------------------
// Copyright (c) The Standard Community, a coalition of the Good-Hearted Engineers
// -------------------------------------------------------------------------------------------

namespace CleanParser.Services.Foundations
{
    internal class Class
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string FullName => $"{Namespace}.{Name}";
        public string FileName => $"{Name}.cs";
        public string FilePath => $"{Namespace}\\{FileName}";
        public string Content { get; set; }
    }
    
    internal class Class2
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string FullName => $"{Namespace}.{Name}";
        public string FileName => $"{Name}.cs";
        public string FilePath => $"{Namespace}\\{FileName}";
        public string Content { get; set; }
    }
}