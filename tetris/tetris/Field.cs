using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Field
    {
        private static int _widht = 40;
        private static int _height = 30;

        public static int Width
        {
            get
            {
                return _widht;
            }
            set
            {
                _widht = value;
                Console.SetWindowSize(Field._widht, Field._height);
                Console.SetBufferSize(Field._widht, Field._height);
            }
        }

        public static int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                Console.SetWindowSize(Field._widht, Field._height);
                Console.SetBufferSize(Field._widht, Field._height);
            }
        }
    }
}
