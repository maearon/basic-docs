import java.awt.*;
class Labeltest extends Frame
{
	Label label1 =new Label("This is just a label");
	public Labeltest(String title)
	{
		super(title);
		add(label1);
	}
	public static void main(String args[])
	{
		Labeltest f=new Labeltest("Label");
		f.setSize(300,200);
		f.show();
	}
}