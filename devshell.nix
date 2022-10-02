{ pkgs }:

with pkgs;

devshell.mkShell {
  packages = [
    dotnet-sdk
  ];
}
