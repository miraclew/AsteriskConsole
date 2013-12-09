using System;
namespace VisualAsterisk.Asterisk
{
    interface IAsteriskServerComponent
    {
        void Disconnected();
        void Initialize();
    }
}
