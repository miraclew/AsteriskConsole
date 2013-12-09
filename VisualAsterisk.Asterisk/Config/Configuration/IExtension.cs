using System;
namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public interface IExtension
    {
        string Extension { get; set; }
        string Descripton { get; }
    }
}
