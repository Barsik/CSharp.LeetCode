FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CSharp.LeetCode/CSharp.LeetCode.csproj", "CSharp.LeetCode/"]
RUN dotnet restore "CSharp.LeetCode/CSharp.LeetCode.csproj"
COPY . .
WORKDIR "/src/CSharp.LeetCode"
RUN dotnet build "CSharp.LeetCode.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CSharp.LeetCode.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CSharp.LeetCode.dll"]
