using System;

namespace EventDelegate_1
{
    class BookEventArgs : EventArgs
    {
        public Book Book { get; set; }
    }
}