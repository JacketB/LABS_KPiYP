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
Memo1.Clear(); //������� ����
 if (TreeView1.Selected.AbsoluteIndex=1) then begin //���� ������ "� ���������" � ����� ������
     Memo1.Lines.LoadFromFile('documentation/� ���������.txt'); //��������� ���� "� ���������.txt"
     Image1.Visible:=false; //�������� c ������������ - "�� �����"
 end;
  if (TreeView1.Selected.AbsoluteIndex=2) then begin //���� ������ "�� ������" � ����� ������
     Memo1.Lines.LoadFromFile('documentation/�� ������.txt'); //��������� ���� "�� ������.txt"
     Image1.Visible:=true; //�������� c ������������ - "�����"
  end;
  if (TreeView1.Selected.AbsoluteIndex=3) then begin //���� ������ "�������" � ����� ������
     Memo1.Lines.LoadFromFile('documentation/�������.txt'); //��������� ���� "�������.txt"
     Image1.Visible:=false; //�������� c ������������ - "�� �����"
  end;
end;

end.
