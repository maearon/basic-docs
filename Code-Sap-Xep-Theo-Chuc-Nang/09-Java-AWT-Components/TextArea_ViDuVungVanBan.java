import java.awt.*;
class TextAreatest extends Frame
{
	Label lb1 =new Label("Details");
	TextArea ta1=new TextArea();
	public TextAreatest(String title)
	{
		super(title);
		setLayout(new FlowLayout());
		add(lb1);
		add(ta1);
	}
	public static void main(String args[])
	{
		TextAreatest t=new TextAreatest("TextArea");
		t.setSize(300,200);
		t.show();
	}
}