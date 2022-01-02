# Port Manager

Permite criar, remover e reiniciar portas no range indicado.

## 📝 Requisitos

.Net Core 3.1

## ⌨ Uso

Single file build com o runtime embutido (não necessita instalar o .net core 3.1 na máquina que vai rodar o aplicativo):

```bash
git clone https://github.com/mabner/PortManager.git
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true
```

Pra fazer o build normal, com dependencia do runtime estar instalado na máquina:

```bash
dotnet build
```
