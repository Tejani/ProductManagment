*** As mentioned below, the Nuget package must be installed on the project. ***


ProductManagement.API
	dotnet add package MediatR --version 11.1.0
	dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.7
	dotnet add package FluentValidation --version 12.0.0
	dotnet add package FluentValidation.DependencyInjectionExtensions --version 12.0.0

ProductManagement.Application
	dotnet add package MediatR.Extensions.Microsoft.DependencyInjection --version 11.1.0
	dotnet add package FluentValidation --version 12.0.0
	
ProductManagement.Infrastructure
	dotnet add package Microsoft.EntityFrameworkCore --version 9.0.7
	dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.7
	

*** Migration Script ***	
dotnet ef migrations add InitialCreate --project ProductManagement.Infrastructure --startup-project ProductManagement.API
dotnet ef database update --project ProductManagement.Infrastructure --startup-project ProductManagement.API



*** Post Request ***
curl -X 'POST' \
  'https://localhost:7277/api/Products' \
  -H 'accept: */*' \
  -H 'Content-Type: application/json' \
  -d '{
  "name": "Dell Keyboard",
  "description": "Dell Mechanical Keyboard",
  "category": "Keyboard",
  "price": 120,
  "variants": [
    {
      "size": "M",
      "color": "Black"
    },
    {
      "size": "L",
      "color": "Orange"
    },
    {
      "size": "S",
      "color": "Green"
    }
  ]
}'


*** Gel All ***
curl -X 'GET' \
  'https://localhost:7277/api/Products' \
  -H 'accept: */*'
  
  
*** Get By Product Id ***
curl -X 'GET' \
  'https://localhost:7277/api/Products/142fcbf2-7476-4870-bfb1-b69949550272' \
  -H 'accept: */*'