using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekoForms.Utils
{
    public class DuplicateCheck
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public long Size { get; set; }

        public DuplicateCheck(int width, int height, long size)
        {
            this.Width = width;
            this.Height = height;
            this.Size = size;
        }

        public bool DuplicateCheck_Current(ref List<ImageProfile> _imageList)
        {
            bool widthFlag = false;
            bool heightFlag = false;
            bool sizeFlag = false;

            for (int i = 0; i < _imageList.Count; i++)
            {
                if (_imageList[i].Width == this.Width)
                {
                    widthFlag = true;
                }
                if (_imageList[i].Height == this.Height)
                {
                    heightFlag = true;
                }
                if (_imageList[i].Size == this.Size)
                {
                    sizeFlag = true;
                }

                if (widthFlag == true &&
                    heightFlag == true &&
                    sizeFlag == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
