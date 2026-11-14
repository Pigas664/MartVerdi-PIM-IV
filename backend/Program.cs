// ==================================================
// CONFIGURAÇÃO PRINCIPAL DA APLICAÇÃO MARTVERDI
// ==================================================

var builder = WebApplication.CreateBuilder(args);


// ==================================================
// CONTROLLERS
// Habilita os Controllers da aplicação.
// É isso que permite que o ASP.NET Core
// reconheça nosso ProdutosController.
// ==================================================

builder.Services.AddControllers();


var app = builder.Build();


// ==================================================
// ARQUIVOS PADRÃO
// Procura arquivos como index.html
// quando acessamos a página inicial "/"
// ==================================================

app.UseDefaultFiles();


// ==================================================
// ARQUIVOS ESTÁTICOS
// Permite entregar HTML, CSS, JavaScript,
// imagens e outros arquivos do wwwroot.
// ==================================================

app.UseStaticFiles();


// ==================================================
// CONTROLLERS / API
// Ativa as rotas dos Controllers.
// ==================================================

app.MapControllers();


// ==================================================
// INICIALIZAÇÃO DO SERVIDOR
// ==================================================

app.Run();