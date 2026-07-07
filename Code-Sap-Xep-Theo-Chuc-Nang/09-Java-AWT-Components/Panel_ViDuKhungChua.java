import java.awt.*;
class Paneltest extends Panel
{
	public static void main(String args[])
	{
		Paneltest p=new Paneltest();
		Frame f=new Frame("Testing a Panel");
		f.add(p);
		f.setSize(300,200);
		f.setVisible(true);
	}
	public Paneltest()
	{
	}
}