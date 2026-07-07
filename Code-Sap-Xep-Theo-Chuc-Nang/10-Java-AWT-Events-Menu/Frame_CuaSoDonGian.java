import java.awt.*;
class FrameDemo extends Frame
{
	public FrameDemo(String title)
	{
		super(title);
	}
	public static void main(String args[])
	{
		FrameDemo f=new FrameDemo("I have been Frameed!!");
		f.setSize(300,200);
		f.setVisible(true);
	}
}