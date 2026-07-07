import java.awt.*;
class Fltest extends Frame
{
	Button b1=new Button("Center Aligned Button 1");
	Button b2=new Button("Center Aligned Button 2");
	Button b3=new Button("Center Aligned Button 3");
	public Fltest(String title)
	{
		super(title);
		setLayout(new FlowLayout(FlowLayout.CENTER));
		add(b1);
		add(b2);
		add(b3);
	}
	public static void main(String args[])
	{
		Fltest t=new Fltest("Flow Layout");
		t.setSize(300,200);
		t.show();
	}
}