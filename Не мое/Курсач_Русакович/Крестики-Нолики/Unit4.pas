unit Unit4;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TSetting = class(TForm)
    colorPlayername1: TLabel;
    colorPlayername2: TLabel;
    colorX: TLabel;
    colorO: TLabel;
    ButtonOK: TButton;
    ColorDialog1: TColorDialog;
    Label1: TLabel;
    Label2: TLabel;
    RadioButton1: TRadioButton;
    RadioButton2: TRadioButton;
    procedure ButtonOKClick(Sender: TObject);
    procedure colorPlayername1Click(Sender: TObject);
    procedure colorPlayername2Click(Sender: TObject);
    procedure colorXClick(Sender: TObject);
    procedure colorOClick(Sender: TObject);
    procedure RadioButton2Click(Sender: TObject);
    procedure RadioButton1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Setting: TSetting;
  colorXA:string;

implementation

{$R *.dfm}
uses Unit1, Unit2;

procedure TSetting.ButtonOKClick(Sender: TObject); //������ "��"
begin
  Game.playername1.Font.Color:=colorPlayername1.Font.Color; //����������� ���� ������� ������ � ������� ���� ����� ������ �� ��������
  Game.playername2.Font.Color:=colorPlayername2.Font.Color; //����������� ���� ������� ������ � ������� ���� ����� ������ �� ��������
  Game.score1.Font.Color:=colorPlayername1.Font.Color; //���� ����� ������� ��������� ����� ����
  Game.score2.Font.Color:=colorPlayername2.Font.Color; //���� ����� ������� ��������� ����� ����
  Close();
end;

procedure TSetting.colorOClick(Sender: TObject); //������� �� "���� �-��"
begin
 if ColorDialog1.Execute then colorO.Font.Color:=ColorDialog1.Color; //����������� ��������� ���� � ����
end;

procedure TSetting.colorPlayername1Click(Sender: TObject); //������� �� ��� ������� ������
begin
  if ColorDialog1.Execute then colorplayername1.Font.Color:=ColorDialog1.Color; //����������� ��������� ���� � ����� ���-� ������� ������
end;

procedure TSetting.colorPlayername2Click(Sender: TObject); //������� �� ��� ������� ������
begin
  if ColorDialog1.Execute then colorPlayername2.Font.Color:=ColorDialog1.Color; //����������� ��������� ���� � ����� ���� ������� ������
end;

procedure TSetting.colorXClick(Sender: TObject); //������� �� "���� X-�"
begin
    if ColorDialog1.Execute then colorX.Font.Color:=ColorDialog1.Color; //����������� ��������� ���� � ����
end;



procedure TSetting.RadioButton1Click(Sender: TObject); //"������ ����"
begin
Game.backgroundblack.Visible := true; //��������� ������ ����� ���� (��������)
Game.baclgroundwhite.Visible := false; //������� ��������� ������� ����� ���� (��������)
Game.Color := clGray; //���� ���� - �����
Game.playername1.Font.Color:=clBlack; //���� ������ ���� ������� ������ �� ������� ���� - ������
Game.playername2.Font.Color:=clBlack; //���� ������ ���� ������� ������  �� ������� ����- ������
colorplayername1.Font.Color:= clBlack; //���� ������ ���� ������� ������ - ������
colorplayername2.Font.Color:= clBlack;  //���� ������ ���� ������� ������ - ������
Game.Image1.Visible:=true; //�������� "VS" ��������� ���
Game.Image2.Visible:=false; //�������� "VS" ��������� ����
Color:=clWindowFrame; //����� ���� ����� ��������
end;

procedure TSetting.RadioButton2Click(Sender: TObject); //"������� ����"
begin
Game.backgroundblack.Visible := false; //��������� ������� ����� ���� (��������)
Game.baclgroundwhite.Visible := true; //������� ��������� ������ ����� ���� (��������)
Game.Color := clTeal; //���� ���� - ������
Game.Cell1.Color :=clAqua;
Game.Cell2.Color :=clAqua;
Game.Cell3.Color :=clAqua;
Game.Cell4.Color :=clAqua;
Game.Cell5.Color :=clAqua;
Game.Cell6.Color :=clAqua;
Game.Cell7.Color :=clAqua;
Game.Cell8.Color :=clAqua;
Game.Cell9.Color :=clAqua;
Game.playername1.Font.Color:=clAqua; //���� ������ ���� ������� ������ �� ������� ���� - �����
Game.playername2.Font.Color:=clAqua; //���� ������ ���� ������� ������  �� ������� ����- �����
colorplayername1.Font.Color:= clAqua; //���� ������ ���� ������� ������ - �����
colorplayername2.Font.Color:= clAqua;  //���� ������ ���� ������� ������ - �����
Game.Image1.Visible:=false; //�������� "VS" ��������� ����
Game.Image2.Visible:=true; //�������� "VS" ��������� ���
Color:=clGray; //���� ����� ���� ����� ��������
end;

end.
