unit Unit1;


interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls,
  Vcl.Imaging.jpeg;

type
  TLogin = class(TForm)
    player1Label: TLabel;
    player1Edit: TEdit;
    player2Label: TLabel;
    player2Edit: TEdit;
    PlayButton: TButton;
    ExitButton: TButton;
    Background: TImage;
    Label1: TLabel;
    Label2: TLabel;
    procedure PlayButtonClick(Sender: TObject);
    procedure ExitButtonClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Login: TLogin;
  player1,player2:string; //���������� ����

implementation

{$R *.dfm}

uses Unit2, Unit4;


procedure TLogin.PlayButtonClick(Sender: TObject);
begin
player1 :=player1Edit.Text;  //� ���������� ��������� ��������� �����
player2 :=player2Edit.Text;  //� ���������� ��������� ��������� �����
 if (player1.Length>5) or (player1.Length<3) then MessageDlg('������� �������� ��� ������� ��� ������� ������', mtWarning,[mbOk],0); //���� �������� ��� ������ 6 ��� ������ 3 - ������
 if (player2.Length>5) or (player2.Length<3) then MessageDlg('������� �������� ��� ������� ��� ������� ������', mtWarning,[mbOk],0); //����������
 if (((player1Edit.Text <> '') and (player2Edit.Text <> '')) and (player1.Length >= 3) and (player2.Length >=3) and (player1.Length < 6) and (player2.Length <6)) then //���� ���� �� ������ � ����� ������ 2-�
 begin
 Game.Show; //���������� �������� ����� � �����
 Setting.colorPlayername1.Caption := player1; //� ����� � ����������� ��������� ��� ������ 1
 Setting.colorPlayername2.Caption:=player2; //� ����� � ����������� ��������� ��� ������ 2
 Visible:=false; //����� ��������
 end;

end;



procedure TLogin.ExitButtonClick(Sender: TObject);
begin
close(); //�������� ���������
end;

end.
