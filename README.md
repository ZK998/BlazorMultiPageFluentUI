##  该项目使用Microsoft.FluentUI基于iframe实现blazor项目tabs page

######  声明：借鉴liningit 的BlazorWebassemblyMultiPagesTab的代码实现（https://github.com/liningit/BlazorWebassemblyMultiPagesTab.git）
######  感谢liningit的贡献

###  使用说明 

*可单独将BlazorMultiPageLib项目下载到本地

#### 1、创建wasm项目:（或Server项目）
`` dotnet new -int WebAssembly -o ProjectName ``

#### 2、引入BlazorMultiPageLib项目

``dotnet sln add "xx\xx\BlazorMultiPageLib.csproj"``

#### 3、删除新项目中的Layout文件夹

#### 4、删除新项目中wwwroot下的bootstrap和app.css（可选）

#### 5、修改Server端Program.cs文件
```
  +builder.Services.AddBlazoredLocalStorage();
  +builder.Services.AddFluentUIComponents();
  ...
  app.MapRazorComponents<App>() 
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorApp.Client._Imports).Assembly)
    +.AddAdditionalAssemblies(typeof(BlazorMultiPageLib._Imports).Assembly);  
```

#### 6、修改Client端Program.cs文件
```
  +builder.Services.AddBlazoredLocalStorageAsSingleton();
  +builder.Services.AddFluentUIComponents(); 
```
#### 7、修改Routers.razor文件  
（如果采用wasm模式，将Routers.razor文件放入Client项目根目录,否则会报xxx.Components.Routes' could not be found in the assembly 'xxx'）

```
   <Router AppAssembly="typeof(Program).Assembly" AdditionalAssemblies="new[] { typeof(Client._Imports).Assembly,typeof(BlazorMultiPageLib._Imports).Assembly  }">
      <Found Context="routeData">
        <RouteView RouteData="routeData" DefaultLayout="typeof(BlazorMultiPageLib.Layout.MainLayout)" />
        <FocusOnNavigate RouteData="routeData" Selector="h1" />
      </Found>
  </Router>
```

#### 8、修改App.razor
 ```   
    +<link href="_content/Microsoft.FluentUI.AspNetCore.Components/css/reboot.css" rel="stylesheet" />
    
    +<link rel="stylesheet" href="_content/BlazorMultiPageLib/app.css" /> 
    
    <Routes @rendermode="InteractiveWebAssembly" /> 
    
    +<script src="_content/Microsoft.FluentUI.AspNetCore.Components/Microsoft.FluentUI.AspNetCore.Components.lib.module.js" type="module" async></script>
    
 ```
 

