import java.awt.*;
class Bltest extends Frame
{
	Button b1=new Button("North");
	Button b2=new Button("Center");
	Button b3=new Button("West");
	Button b4=new Button("East");
	Button b5=new Button("South");
	public Bltest(String title)
	{
		super(title);
		setLayout(new BorderLayout());
		add(b1,BorderLayout.NORTH);
		add(b2,BorderLayout.CENTER);
		add(b3,BorderLayout.WEST);
		add(b4,BorderLayout.EAST);
		add(b5,BorderLayout.SOUTH);
	}
	public static void main(String args[])
	{
		Bltest t=new Bltest("Border Layout");
		t.setSize(300,200);
		t.show();
	}
}