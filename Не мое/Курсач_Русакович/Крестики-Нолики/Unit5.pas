unit Unit5;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Imaging.jpeg,
  Vcl.ExtCtrls, Vcl.ComCtrls;

type
  TInfo = class(TForm)
    TreeView1: TTreeView;
    Memo1: TMemo;
    Image1: TImage;
    procedure TreeView1Change(Sender: TObject; Node: TTreeNode);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Info: TInfo;

implementation

{$R *.dfm}



procedure TInfo.TreeView1Change(Sender: TObject; Node: TTreeNode);
begin
Memo1.Clear(); //Очистка Мемо
 if (TreeView1.Selected.AbsoluteIndex=1) then begin //если выбран "О программе" в ветке дерева
     Memo1.Lines.LoadFromFile('documentation/О Программе.txt'); //открываем файл "О Программе.txt"
     Image1.Visible:=false; //картинка c изображением - "не видна"
 end;
  if (TreeView1.Selected.AbsoluteIndex=2) then begin //если выбран "Об авторе" в ветке дерева
     Memo1.Lines.LoadFromFile('documentation/Об авторе.txt'); //открываем файл "Об авторе.txt"
     Image1.Visible:=true; //картинка c изображением - "видна"
  end;
  if (TreeView1.Selected.AbsoluteIndex=3) then begin //если выбран "Справка" в ветке дерева
     Memo1.Lines.LoadFromFile('documentation/Справка.txt'); //открываем файл "Справка.txt"
     Image1.Visible:=false; //картинка c изображением - "не видна"
  end;
end;

end.
