﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle
    {

        private int _length;
        private int _width;

        public Rectangle()
        {
            _length = 1;
            _width = 1;
        }
        public Rectangle(int length,int width)
        {
            _length = length;
            _width = width;
        }
        public int GetLength()
        {
            return _length;
        }
        public int SetLength(int length)
        {
            _length =  length;
            return _length;
        }

        public int SetWidth()
        {
            throw new NotImplementedException();
        }

        public int GetWidth()
        {
            return _width;
        }
        public int SetWidth(int width)
        {
            _width = width;
            return _width;
        }
        public int GetPerimeter()
        {           
            return 2 *_length + 2 * _width;
        }
        public int GetArea()
        {            
            return _length * _width;
        }
    }
}
