﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace DelegatesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
           Action<Photo> filterHandler = filters.ApplyContrast;
            filterHandler += filters.ApplyBrightness;
            filterHandler += filters.ApplyReszie;
            photoProcessor.Process("", filterHandler);


        }

        public void RemoveRedEye(Photo photo)
        {
            System.Console.WriteLine("remove red eye");
        }
    }
}
