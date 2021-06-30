#define URL "https://github.com/SP3KTRAL"
#define ExeName "NoteAppUI.exe"
#define Name "NoteApp"
#define NameInstallations "NoteAppSetup"
#define Version "1.0.0"

[Setup]
AppId={{CDB6DAB6-3C70-46E8-8CD3-B0983E2C0642}}
AppName={#Name}
AppVersion={#Version}
AppPublisherURL={#URL}
AppSupportURL={#URL}
AppUpdatesURL={#URL}
DefaultDirName={pf}\{#Name}
DefaultGroupName={#Name}
DisableProgramGroupPage=yes
OutputBaseFilename={#NameInstallations}
SetupIconFile="..\icon\NoteApp.ico"
UninstallDisplayName={#Name}
UninstallDisplayIcon="..\icon\NoteApp.ico"
OutputDir="Installers"
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: "{cm:AdditionalIcons}" 

[Files]
Source: "Release\NoteAppUI.exe"; DestDir: "{app}"
Source: "Release\*.dll"; DestDir: "{app}"
Source: "..\icon\NoteApp.ico"; DestDir: "{app}"

[Icons]
Name: "{group}\{#Name}"; Filename: "{app}\{#ExeName}"; WorkingDir: "{app}"; IconFilename: {app}\NoteApp.ico
Name: "{group}\{#Name}"; Filename: "{uninstallexe}"; IconFilename: {app}\NoteApp.ico
Name: "{commondesktop}\{#Name}"; Filename: "{app}\{#ExeName}"; Tasks: desktopicon; IconFilename: {app}\NoteApp.ico




