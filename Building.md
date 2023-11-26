# Building DotDevelop

To build DotDevelop from scratch you will need to following pre-requisites.

Please note, Ubuntu 20.04 LTS is the perferred environment for buiding from source as Ubuntu 22.04 LTS doesn’t support .NET Core 3.1 or 2.0 since the distro only supports openSSL 3.

## Build Environment Requirements

The following steps are for Ubuntu, other distros may require different URLs.

```bash
sudo apt update
sudo apt install wget
sudo apt install intltool fsharp gtk-sharp2

# DotNet
## Ubuntu 20.04
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

## Ubuntu 22.04
# wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
# sudo dpkg -i packages-microsoft-prod.deb
# rm packages-microsoft-prod.deb

sudo apt-get install -y apt-transport-https
sudo apt-get update && sudo apt-get install -y dotnet-sdk-3.1
sudo apt-get update && sudo apt-get install -y dotnet-sdk-5.0
sudo apt-get update && sudo apt-get install -y dotnet-sdk-6.0

# Install Mono and MSBuild
sudo apt-get install -y gnupg ca-certificates
sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF

# Reference mono and msbuild from stable repo for versions 6.12.0.122 (mono) and 16.6.0.15201 (msbuild)
echo "deb https://download.mono-project.com/repo/ubuntu stable-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list

# Reference mono and msbuild from preview repo for versions 6.12.0.147 (mono) and 16.10.1 (msbuild)
# echo "deb https://download.mono-project.com/repo/ubuntu preview-focal main" | sudo tee /etc/apt/sources.list.d/mono-official-preview.list
sudo apt-get update

# Install mono-complete and ca-certificates-mono
sudo apt-get install -y mono-complete ca-certificates-mono

# Synchronise Mono SSL certs
cert-sync /etc/ssl/certs/ca-certificates.crt

# Install extra packages required for dotdevelop build
sudo apt-get install -y sed git build-essential intltool nuget fsharp gtk-sharp2
sudo apt-get install -y software-properties-common
sudo apt-get update

# NetCoreDbg Requirements
sudo apt install curl
sudo apt install -y cmake clang
```

## Clone and Building

Build DotDevelop

```bash
git clone -b main https://github.com/dotdevelop/dotdevelop.git
cd dotdevelop/

./configure --profile=gnome
make
```

Build NetCoreDbg, starting from the root of the `dotdevelop` folder.

```bash
# Build NetCoreDbg (starting from DotDevelop directory)
cd main/external/Samsung.Netcoredbg
bash build.sh
cd ../../..
```

## Launching the IDE

Launch DotDevelop, using one of the 2 options

```bash
# Start detached from terminal window
(mono main/build/bin/MonoDevelop.exe &)

# Start attached to terminal window
mono main/build/bin/MonoDevelop.exe
```

## Building using Dotdevelop
once you have a sucessfull build on Linux you can also start Dotdevelop for building Dotdevelop
```bash
git clone -b main https://github.com/dotdevelop/dotdevelop.git
git submodule update --init
cd main
nuget restore
```

open Main.sln from Dotdevelop 
select Mondevelop.Startup and DebugGnome!!

### Verify .NET Core Debugger is attached

1. Launch, MonoDevelop
2. Edit > Preferences > Projects > .NET Core Debuggers
3. Click `...` and navigate to, `main/build/AddIns/Samsung.Netcoredbg/netcoredbg`
4. Click, OK and start debugging  


### Running DotDevelop with .NET6.0+ installed

With dotnet-sdk-6.0+ installed, the following error occurs:-  

"MSB4236 WorkloadAutoImportPropsLocator could not be found".  

This is described by  [this issue](https://github.com/dotnet/sdk/issues/17461) with the following workaround:-   

Set the environment variable `MSBuildEnableWorkloadResolver=false` prior to starting monodevelop  

eg, in a terminal, before starting dotdevelop as above...   
  
```bash
export MSBuildEnableWorkloadResolver=false
mono ./main/build/bin/MonoDevelop.exe --no-redirect 
```
### CI mainfest
Take a look at [the CI manifest](https://github.com/dotdevelop/dotdevelop/blob/main/.github/workflows/monodevelop.yml) in case the latest steps differ from above.

## References

* [NetCoreDbg - Readme.md](https://github.com/dotdevelop/netcoredbg/tree/dotdevelop#readme)
  * [Samsung NetCoreDbg](https://github.com/Samsung/netcoredbg)
* [Issue #19 - Samsung.NetCoreDbg External Package](https://github.com/dotdevelop/dotdevelop/issues/47)
