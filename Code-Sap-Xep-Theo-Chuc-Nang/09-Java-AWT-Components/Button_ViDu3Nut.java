import java.awt.*;
class Buttontest extends Frame
{
	Button b1 =new Button("Red");
	Button b2 =new Button("Green");
	Button b3 =new Button("Blue");
	public Buttontest(String title)
	{
		super(title);
		setLayout(new FlowLayout());
		add(b1);
		add(b2);
		add(b3);
	}
	public static void main(String args[])
	{
		Buttontest t=new Buttontest("Button");
		t.setSize(300,200);
		t.show();
	}
}