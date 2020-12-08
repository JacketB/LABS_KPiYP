unit Unit2;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.Imaging.jpeg,
  Vcl.Imaging.pngimage, Vcl.Menus, Vcl.StdCtrls;

type
  TGame = class(TForm)
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    N3: TMenuItem;
    N4: TMenuItem;
    backgroundblack: TImage;
    playername1: TLabel;
    playername2: TLabel;
    Image1: TImage;
    Cell1: TLabel;
    Cell2: TLabel;
    Cell3: TLabel;
    Cell6: TLabel;
    Cell9: TLabel;
    Cell8: TLabel;
    Cell7: TLabel;
    Cell4: TLabel;
    Cell5: TLabel;
    Timer1: TTimer;
    N5: TMenuItem;
    score1: TLabel;
    score2: TLabel;
    Label1: TLabel;
    Label2: TLabel;
    baclgroundwhite: TImage;
    Image2: TImage;
    N6: TMenuItem;
    procedure FormShow(Sender: TObject);
    procedure N2Click(Sender: TObject);
    procedure Cell1Click(Sender: TObject);
    procedure Cell2Click(Sender: TObject);
    procedure Cell3Click(Sender: TObject);
    procedure Cell4Click(Sender: TObject);
    procedure Cell5Click(Sender: TObject);
    procedure Cell6Click(Sender: TObject);
    procedure Cell7Click(Sender: TObject);
    procedure Cell8Click(Sender: TObject);
    procedure Cell9Click(Sender: TObject);
    procedure N5Click(Sender: TObject);
    procedure N3Click(Sender: TObject);
    procedure N4Click(Sender: TObject);
    procedure N6Click(Sender: TObject);
    procedure FormClose(Sender: TObject; var Action: TCloseAction);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Game: TGame;
  Tag: integer;
  player1, player2:string; //���������� ��� ������
  sscore1,sscore2:integer; //���������� ����� �������
implementation

{$R *.dfm}
uses Unit1, Unit3, Unit4, Unit5;
procedure winlose; //��������� �������� ������
begin
//!!!!������ ��� ���������� ���� � �����, �� ����������� ���������� Label(� ��������� Cell1-9)!!!!
//������ ���
if (Game.Cell1.Caption <> '') and  (Game.Cell2.Caption <> '') and  (Game.Cell3.Caption <> '') then //���� ��� �� ������
 if (Game.Cell1.Caption = Game.Cell2.Caption) and  (Game.Cell2.Caption = Game.Cell3.Caption) then begin //���� ��� �� ����������
   if (Game.Cell1.Caption = ' X') and  (Game.Cell2.Caption = ' X') and  (Game.Cell3.Caption = ' X') then begin  //���� ������ � ���� ����� ����
   sscore1 := sscore1+1; //�� ����� ������� ������ ��������� 1
   Game.score1.Caption := IntToStr(sscore1); //������� ����
   MessageWin.Message.Caption :=player1; //��������� � ����� � ���������� ��� ������� ������
   MessageWin.Show; //������� ����� � ����������
   Game.N2.Click; //������ "����� ����", �.�. ������� ������� ����
   end else begin //���� ������ ��� ������� ���� (�.�. ����� ����)
   sscore2 := sscore2+1; //�� ����� ������� ������ ��������� 1
   Game.score2.Caption := IntToStr(sscore2); //������� ����
   MessageWin.Message.Caption := player2; //��������� � ����� � ���������� ��� ������� ������
   MessageWin.Show; //������� ����� � ����������
   Game.N2.Click; //������ "����� ����", �.�. ������� ������� ����
   end;
 end;

//������ ���
if (Game.Cell4.Caption <> '') and  (Game.Cell5.Caption <> '') and  (Game.Cell6.Caption <> '') then
 if (Game.Cell4.Caption = Game.Cell5.Caption) and  (Game.Cell5.Caption = Game.Cell6.Caption) then begin
   if (Game.Cell4.Caption = ' X') and  (Game.Cell5.Caption = ' X') and  (Game.Cell6.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

//������ ���
if (Game.Cell7.Caption <> '') and  (Game.Cell8.Caption <> '') and  (Game.Cell9.Caption <> '') then
 if (Game.Cell7.Caption = Game.Cell8.Caption) and  (Game.Cell8.Caption = Game.Cell9.Caption) then begin
   if (Game.Cell7.Caption = ' X') and  (Game.Cell8.Caption = ' X') and  (Game.Cell9.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

//��������� ���
 if (Game.Cell1.Caption <> '') and  (Game.Cell4.Caption <> '') and  (Game.Cell7.Caption <> '') then
 if (Game.Cell1.Caption = Game.Cell4.Caption) and  (Game.Cell4.Caption = Game.Cell7.Caption) then begin
   if (Game.Cell1.Caption = ' X') and  (Game.Cell4.Caption = ' X') and  (Game.Cell7.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

//����� ���
if (Game.Cell2.Caption <> '') and  (Game.Cell5.Caption <> '') and  (Game.Cell8.Caption <> '') then
 if (Game.Cell2.Caption = Game.Cell5.Caption) and  (Game.Cell5.Caption = Game.Cell8.Caption) then begin
   if (Game.Cell2.Caption = ' X') and (Game.Cell5.Caption = ' X') and  (Game.Cell8.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

//������ ���
if (Game.Cell3.Caption <> '') and  (Game.Cell6.Caption <> '') and  (Game.Cell9.Caption <> '') then
 if (Game.Cell3.Caption = Game.Cell6.Caption) and  (Game.Cell6.Caption = Game.Cell9.Caption) then begin
   if (Game.Cell3.Caption = ' X')  and  (Game.Cell6.Caption = ' X') and  (Game.Cell9.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

//������� ���
if (Game.Cell1.Caption <> '') and  (Game.Cell5.Caption <> '') and  (Game.Cell9.Caption <> '') then
 if (Game.Cell1.Caption = Game.Cell5.Caption) and  (Game.Cell5.Caption = Game.Cell9.Caption) then begin
   if (Game.Cell1.Caption = ' X') and  (Game.Cell5.Caption = ' X') and  (Game.Cell9.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

//������� ���
 if (Game.Cell3.Caption <> '') and  (Game.Cell5.Caption <> '') and  (Game.Cell7.Caption <> '') then
 if (Game.Cell3.Caption = Game.Cell5.Caption) and  (Game.Cell5.Caption = Game.Cell7.Caption) then begin
   if (Game.Cell3.Caption = ' X') and  (Game.Cell5.Caption = ' X') and  (Game.Cell7.Caption = ' X') then begin
   sscore1 := sscore1+1;
   Game.score1.Caption := IntToStr(sscore1);
   MessageWin.Message.Caption :=player1;
   MessageWin.Show;
   Game.N2.Click;
   end else begin
   sscore2 := sscore2+1;
   Game.score2.Caption := IntToStr(sscore2);
   MessageWin.Message.Caption := player2;
   MessageWin.Show;
   Game.N2.Click;
   end;
 end;

if (Game.Cell1.Caption <> '') and  (Game.Cell2.Caption <> '') and  (Game.Cell3.Caption <> '') and  (Game.Cell4.Caption <> '')and  (Game.Cell5.Caption <> '') and  (Game.Cell6.Caption <> '') and  (Game.Cell6.Caption <> '') and  (Game.Cell7.Caption <> '') and  (Game.Cell8.Caption <> '') and  (Game.Cell9.Caption <> '') then begin
  MessageWin.Message.Caption := '������';
  MessageWin.Show;
  Game.N2.Click;
end;

end;

procedure clean; //��������� ������ ������ ("����� ����")
begin
 Game.Timer1.Enabled:=false;  //��� ���������� ��������� ������
 Game.Cell1.Caption:='';      //������� ��������� ������� ������
 Game.Cell2.Caption:='';      //������� ��������� ������� ������
 Game.Cell1.Caption:='';      //������� ��������� �������� ������
 Game.Cell4.Caption:='';      //������� ��������� ���������� ������
 Game.Cell5.Caption:='';      //������� ��������� ������ ������
 Game.Cell6.Caption:='';      //������� ��������� ������� ������
 Game.Cell7.Caption:='';      //������� ��������� �������� ������
 Game.Cell8.Caption:='';      //������� ��������� �������� ������
 Game.Cell9.Caption:='';      //������� ��������� �������� ������
 Game.Tag:=0;
 Game.Timer1.Enabled:=true;   //������������ ������ �������
end;

//!!!!��� �������� ����� ���������� ���, �� ����������� �������� �������!!!!
procedure TGame.Cell1Click(Sender: TObject); //������ �������
begin
if Cell1.Caption<>'' then exit; //�������� �� ��������� ������ (����-������)
 if Tag=0
  then //������ tag ����� (��� ����������� X � O)
   begin
    Cell1.Font.Color:=Setting.colorX.Font.Color; //����������� ���� �-� � ����� ��������
    Cell1.Caption:=' X'; //���� ��� = 0 ����� ��������� X
    Tag:=1;
   end
  else
   begin
    Cell1.Font.Color:=Setting.colorO.Font.Color; //����������� ���� �-� � ����� ��������
    Cell1.Caption:=' O'; //���� ��� = 1 ����� ��������� O
    Tag:=0;
   end;
   winlose; //��������� �������� �� ������
end;

procedure TGame.Cell2Click(Sender: TObject); //������ �������
begin
if Cell2.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell2.Font.Color:=Setting.colorX.Font.Color;
    Cell2.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell2.Font.Color:=Setting.colorO.Font.Color;;
    Cell2.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell3Click(Sender: TObject);
begin
if Cell3.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell3.Font.Color:=Setting.colorX.Font.Color;
    Cell3.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell3.Font.Color:=Setting.colorO.Font.Color;;
    Cell3.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell4Click(Sender: TObject);
begin
if Cell4.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell4.Font.Color:=Setting.colorX.Font.Color;
    Cell4.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell4.Font.Color:=Setting.colorO.Font.Color;;
    Cell4.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell5Click(Sender: TObject);
begin
if Cell5.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell5.Font.Color:=Setting.colorX.Font.Color;
    Cell5.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell5.Font.Color:=Setting.colorO.Font.Color;;
    Cell5.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell6Click(Sender: TObject);
begin
if Cell6.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell6.Font.Color:=Setting.colorX.Font.Color;
    Cell6.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell6.Font.Color:=Setting.colorO.Font.Color;;
    Cell6.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell7Click(Sender: TObject);
begin
if Cell7.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell7.Font.Color:=Setting.colorX.Font.Color;
    Cell7.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell7.Font.Color:=Setting.colorO.Font.Color;;
    Cell7.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell8Click(Sender: TObject);
begin
if Cell8.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell8.Font.Color:=Setting.colorX.Font.Color;
    Cell8.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell8.Font.Color:=Setting.colorO.Font.Color;;
    Cell8.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.Cell9Click(Sender: TObject);
begin
if Cell9.Caption<>'' then exit;
 if Tag=0
  then
   begin
    Cell9.Font.Color:=Setting.colorX.Font.Color;
    Cell9.Caption:=' X';
    Tag:=1;
   end
  else
   begin
    Cell9.Font.Color:=Setting.colorO.Font.Color;;
    Cell9.Caption:=' O';
    Tag:=0;
   end;
      winlose;
end;

procedure TGame.FormClose(Sender: TObject; var Action: TCloseAction);
begin
Login.Visible:=true;
end;

procedure TGame.FormShow(Sender: TObject);
var pname1, pname2:string; //���������� ��� ���-�����
i:integer; //���������� ��� �����
begin
sscore1:=0; //��� �������� ���� ����������
sscore2:=0; //��� �������� ���� ����������
pname1:=UpperCase(Login.player1Edit.Text+':'); //��������� ��� � ������ ����� � ���������� � � ������� �������
playername1.Caption:=pname1; //������� �� �����
pname2:=UpperCase(':'+Login.player2Edit.Text); //��������� ��� � ������ ����� � ���������� � � ������� �������
playername2.Caption:=pname2; //������� �� �����
for i := 2 to pname2.Length do player2:=player2+pname2[i]; //���� ������� �� ����� ������� ������, ��� ":"
label2.Caption:=player2; //���������� � ����������
for i := 1 to pname1.Length-1 do player1:=player1+pname1[i]; //���� ������� �� ����� ������� ������, ��� ":"
label1.Caption:=player1; //���������� � ����������
end;


procedure TGame.N2Click(Sender: TObject); //������ "����� ����"
begin
Cell1.Caption:=''; //������� ������� ������
Cell2.Caption:=''; //������� ������� ������
Cell3.Caption:=''; //������� �������� ������
Cell4.Caption:=''; //������� ���������� ������
Cell5.Caption:=''; //������� ������ ������
Cell6.Caption:=''; //������� ������� ������
Cell7.Caption:=''; //������� �������� ������
Cell8.Caption:=''; //������� �������� ������
Cell9.Caption:=''; //������� �������� ������
end;
procedure TGame.N3Click(Sender: TObject); //������ "�������"
begin
Login.Close(); //��������� �������� �����, �������������, � ��� ���������
end;

procedure TGame.N4Click(Sender: TObject); //������ "� ���������"
begin
Info.Show(); //��������� ����� ����������
end;

procedure TGame.N5Click(Sender: TObject); //������ "���������"
begin
  Setting.Show(); //��������� ����� � �����������
end;

procedure TGame.N6Click(Sender: TObject); //������ "������� ���"
begin
player1:=''; //������� ����� ������� ������
player2:=''; //������� ����� ������� ������
Close(); //�������� �����
end;

end.
