# 💼 TrampoFácil

**TrampoFácil** é uma plataforma que conecta profissionais autônomos a oportunidades de trabalho, facilitando a criação de anúncios, visualização de serviços e gerenciamento de perfis — tudo com segurança e praticidade.

---

## 📑 Índice

- [🧠 Sobre o Projeto](#-sobre-o-projeto)
- [🛠️ Tecnologias Utilizadas](#️-tecnologias-utilizadas)
- [📌 Funcionalidades](#-funcionalidades)
- [📦 Instalação e Execução](#-instalação-e-execução)
- [🔐 Configuração de Ambiente](#-configuração-de-ambiente)
- [🏗️ Arquitetura e Organização](#️-arquitetura-e-organização)
- [🔒 Autenticação JWT](#-autenticação-jwt)
- [❗ Middleware Global de Erros](#-middleware-global-de-erros)
- [🤝 Contribuição](#-contribuição)
- [📝 Licença](#-licença)

---

## 🧠 Sobre o Projeto

O **TrampoFácil** tem como missão aproximar pessoas que oferecem serviços daqueles que precisam contratar, valorizando o trabalho autônomo e promovendo inclusão digital.  
A aplicação possui autenticação JWT, rotas protegidas, tratamento global de erros e separação em camadas (API, Domínio, Aplicação e Infraestrutura).

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core 8
- C#
- Entity Framework Core + PostgreSQL
- JWT (Json Web Token)
- AutoMapper
- FluentValidation
- DotEnv (.env)
- Swagger (Swashbuckle)

---

## 📌 Funcionalidades

- [x] Cadastro e login de usuários
- [x] Geração de token JWT seguro
- [x] Criação e visualização de anúncios
- [x] Cadastro de informações profissionais (InfoPro)
- [x] Denúncia de conteúdo indevido
- [x] Proteção de endpoints com `[Authorize]`
- [x] Middleware Global de tratamento de exceções
- [x] Injeção de dependência e separação por responsabilidades
- [x] DTOs validados com FluentValidation

---

## 📦 Instalação e Execução
```bash

# 1. Clone o repositório
git clone https://github.com/seu-usuario/trampofacil.git

# 2. Navegue até o diretório do projeto
cd trampofacil

# 3. Restaure os pacotes
dotnet restore

# 4. Execute a aplicação
dotnet run
```

🔗 Acesse: http://localhost:5001/swagger para testar via Swagger.

## 🔐 Configuração de Ambiente

Crie um arquivo .env na raiz do projeto com:

```bash
Jwt__SecretKey=TrampoFacil@2024_ProSegura
Jwt__Issuer=TrampoFacilAPI
Jwt__Audience=TrampoFacilClient
ConnectionStrings__DefaultConnection=Host=localhost;Port=5432;Database=trampo;Username=postgres;Password=senha
```
Após criar o .env, execute source ~/.bashrc (Linux/Mac) ou reinicie o terminal (Windows) para carregar as variáveis.

## 🏗️ Arquitetura e Organização
```bash
/TrampoFacil
├── Application
│   ├── Services
│   ├── DTOs
│   └── Validators
├── Domain
│   ├── Models
│   └── Interfaces
├── Infrastructure
│   ├── Data
│   └── Repositories
├── API
│   ├── Controllers
│   ├── Middlewares
│   └── Settings
```
## 🔒 Autenticação JWT
A autenticação é feita por Token JWT, com segurança configurada via middleware.

#  Fluxo:
- POST /api/autenticacao/login
- Recebe DTO de login
- Valida com FluentValidation
- Verifica credenciais no banco
- Gera token e envia como resposta
- Endpoints protegidos exigem:


Authorization: Bearer {seu_token}
Tokens possuem validade configurada e permanecem ativos até expiração ou logout.
