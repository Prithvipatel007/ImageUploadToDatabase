using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImageToDb.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        [DataType(DataType.Upload)]
        public byte[] Img { get; set; }
    }
}
