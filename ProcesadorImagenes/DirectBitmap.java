//
// Translated by CS2J (http://www.cs2j.com): 2/4/2019 9:18:39 PM
//

package ProcesadorImagenes;

import CS2JNet.System.LCC.IDisposable;

public class DirectBitmap   implements IDisposable
{
    private Bitmap __Bitmap = new Bitmap();
    public Bitmap getBitmap() {
        return __Bitmap;
    }

    public void setBitmap(Bitmap value) {
        __Bitmap = value;
    }

    private int[] __Bits;
    public int[] getBits() {
        return __Bits;
    }

    public void setBits(int[] value) {
        __Bits = value;
    }

    private boolean __Disposed;
    public boolean getDisposed() {
        return __Disposed;
    }

    public void setDisposed(boolean value) {
        __Disposed = value;
    }

    private int __Height;
    public int getHeight() {
        return __Height;
    }

    public void setHeight(int value) {
        __Height = value;
    }

    private int __Width;
    public int getWidth() {
        return __Width;
    }

    public void setWidth(int value) {
        __Width = value;
    }

    private GCHandle __BitsHandle = new GCHandle();
    protected GCHandle getBitsHandle() {
        return __BitsHandle;
    }

    protected void setBitsHandle(GCHandle value) {
        __BitsHandle = value;
    }

    public DirectBitmap(int width, int height) throws Exception {
        setWidth(width);
        setHeight(height);
        setBits(new int[width * height]);
        setBitsHandle(GCHandle.Alloc(getBits(), GCHandleType.Pinned));
        setBitmap(new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, getBitsHandle().AddrOfPinnedObject()));
    }

    public void dispose() throws Exception {
        if (getDisposed())
            return ;
         
        setDisposed(true);
        getBitmap().Dispose();
        getBitsHandle().Free();
    }

}


