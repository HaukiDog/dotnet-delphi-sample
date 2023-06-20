library Sample;

uses
  System.SysUtils,
  System.Classes;

{$R *.res}

function Negate(const x: boolean): boolean; stdcall;
begin
  Result := not x;
end;

function Multiply(const x: Integer; const y: Integer): Integer; stdcall;
begin
  try
    Result := y * x;
  except
    Result := -1;
  end;
end;

function Total(const arr: PInteger; count: Integer): Integer; stdcall;
var
  i, total: Integer;
  a: PInteger;
begin
  try
    total:= 0;
    a := arr;
    for i := 1 to count do
    begin
      // do something with each element of the array
      total:= total + a^;
      Inc(a);
    end;
    Result := total;
  except
    Result := -1;
  end;
end;

function WideStringCount(str: PChar): Integer; stdcall;
begin
  Result := Length(str);
end;

function WideStringOut(out str: WideString): Integer; stdcall;
begin
  str := 'Hello';
  Result := 1; // real code would have real error handling
end;

function PCharOut(out str: PChar): Integer; stdcall;
begin
  str := 'Hello';
  Result := 1; // real code would have real error handling
end;

function WideStringReturn(): WideString; stdcall;
begin
  Result := 'Goodbye WideString'
end;

function PCharReturn(): PChar; stdcall;
begin
  Result := 'Goodbye PChar'
end;


function WideStringInOut(const name: PChar; out str: PChar): Integer; stdcall;
begin
  str := PChar('Hello ' + name);
  Result := 1;
end;

exports
  Negate, Multiply, Total,
  WideStringCount, WideStringOut, WideStringInOut, WideStringReturn,
  PCharOut, PCharReturn;

begin
end.
