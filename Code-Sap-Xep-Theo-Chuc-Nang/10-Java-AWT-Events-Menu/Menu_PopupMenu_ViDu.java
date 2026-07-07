import java.awt.*;
import java.awt.event.*;
class MyFrame extends Frame implements ActionListener, MouseListener
{
	MenuItem exitTtem;
	PopupMenu optionsMenu;
	Frame frame;
	public MyFrame()
	{
		setTitle("Menu Example");//Tieu de cua so
		setSize(300,200);//Kich co
		MenuBar mbar=new MenuBar();//Tao thanh thuc don
		setMenuBar(mbar);
		Menu fileMenu=new Menu("File");//KHai bao File
		mbar.add(fileMenu);//Them File vao tren mbar;
		fileMenu.addActionListener(this);
		MenuItem newItem=new MenuItem("New")
		fileMenu.add(newItem);//Them New vao tren File
		MenuItem openItem=new MenuItem("Open");
		fileMenu.add(openItem);
		fileMenu.addSeparator();//Them duong ke ngang
		MenuItem saveItem=new MenuItem("Save");
		fileMenu.add(saveItem);
		MenuItem saveAsItem=new MenuItem("Save As");
		fileMenu.add(saveAsItem);
		fileMenu.addSeparator();
		MenuItem exitItem=new MenuItem("Exit");//errrr
		fileMenu.add(exitItem);
		saveAsItem.addActionListener(this);
		Menu editMenu=new Menu("Exit");
		mbar.add(editMenu);
		editMenu.addActionListener(this);
		MenuItem cutItem=new MenuItem("Cut");
		editMenu.add(cutItem);
		MenuItem copyItem=new MenuItem("Copy");
		editMenu.add(copyItem);
		MenuItem pasteItem=new MenuItem("Paste");
		editMenu.add(pasteItem);
		fileMenu.addSeparator();
		Menu helpMenu=new Menu("Help");
		mbar.add(helpMenu);
		helpMenu.addActionListener(this);
		MenuItem contentItem=new MenuItem("Content");
		helpMenu.add(contentItem);
		MenuItem indexItem=new MenuItem("Index");
		helpMenu.add(indexItem);
		MenuItem findItem=new MenuItem("Find");
		helpMenu.add(findItem);
		addMouseListener(this);
		MenuItem nameItem=new MenuItem("Search by Name");
		helpMenu.add(nameItem);
		MenuItem cacheItem=new MenuItem("Search from cache");
		helpMenu.add(cacheItem);
		optionsMenu=new PopupMenu("Options");
		optionsMenu.addActionListener(this);
		Menu readItem=new Menu("Read Only");
		optionsMenu.add(readItem);
		optionsMenu.addSeparator();
		Menu formatMenu=new Menu("Format Text");
		optionsMenu.add(formatMenu);
		this.add(optionsMenu);
		formatMenu.addActionListener(this);
		CheckboxMenuItem insertItem=new CheckboxMenuItem("Insert",true);
		formatMenu.add(insertItem);
		CheckboxMenuItem overtypeItem=new CheckboxMenuItem("Overtype",false);
		formatMenu.add(overtypeItem);
	}
	public void actionPerformed(ActionEvent ae)
	{
		if(ae.getActionCommand().equals("Exit"))
		{
			System.exit(0);
		}
	}
	public void mouseEntered(MouseEvent m){}
	public void mouseExited(MouseEvent m){}
	public void mouseClicked(MouseEvent m)
	{
		optionsMenu.show(this,m.getX(),m.getY());
	}
	public void mouseReleased(MouseEvent m){}
	public void mousePressed(MouseEvent m){}
	public static void main(String[] args)
	{
		MyFrame frame=new MyFrame();
		frame.show();
	}
}
	
		