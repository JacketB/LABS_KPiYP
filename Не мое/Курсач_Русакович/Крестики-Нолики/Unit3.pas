unit Unit3;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.Imaging.jpeg,
  Vcl.ExtCtrls;

type
  TMessageWin = class(TForm)
    Image1: TImage;
    Message: TLabel;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  MessageWin: TMessageWin;

implementation

{$R *.dfm}
uses Unit2;



end.
