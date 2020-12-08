program Project1;

uses
  Vcl.Forms,
  Unit1 in 'Unit1.pas' {Login},
  Unit2 in 'Unit2.pas' {Game},
  Unit3 in 'Unit3.pas' {MessageWin},
  Unit4 in 'Unit4.pas' {Setting},
  Unit5 in 'Unit5.pas' {Info};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TLogin, Login);
  Application.CreateForm(TGame, Game);
  Application.CreateForm(TMessageWin, MessageWin);
  Application.CreateForm(TSetting, Setting);
  Application.CreateForm(TInfo, Info);
  Application.Run;
end.
