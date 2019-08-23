using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette_Reloaded
{
    class ImageBase : IDisposable
    {
        bool disposed = false;

        Bitmap _bitmap;
        private int X;
        private int Y;

        public int Left { get { return X; } set { X = value; } }
        public int Top { get { return Y; } set { Y = value; } }

        public ImageBase(Bitmap _resource)
        {
            try
            {
                _bitmap = new Bitmap(_resource);
            }
            catch
            { }
        }

        public void DrawImage(Graphics gfx)
        {
            try
            {
                gfx.DrawImage(_bitmap, X, Y);
            }
            catch
            { }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;
            if (disposing)
            {
                _bitmap.Dispose();
            }
            disposed = true;
        }

    }
}
