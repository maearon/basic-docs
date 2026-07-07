import java.awt.*;
class Gltest extends Frame
{
	Button btn[];
	String str[]={"1","2","3","4","5","6","7","8","9"};
	public Gltest(String title)
	{
		super(title);
		setLayout(new GridLayout(3,3));
		btn=new Button[str.length];
		for (int i=0;i<str.length;i++)
		{
			btn[i]=new Button(str[i]);
			add(btn[i]);
		}
	}
	public static void main(String args[])
	{
		Gltest t=new Gltest("Gird Layout");
		t.setSize(300,200);
		t.show();
	}
}