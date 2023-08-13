EF Migration
============


1) Set Environment:
	$env:ASPNETCORE_ENVIRONMENT="Development"
	$env:ASPNETCORE_ENVIRONMENT="DevelopmentSqlite"


2) Add Migration
	add-migration CreateTables -Context DataContext -Project KevArt.Database -OutputDir Migrations\SqlServerMigrations
	add-migration CreateTables -Context DataContextSqlite -Project KevArt.Database -OutputDir Migrations\SqliteMigrations


3) Script a Migration
	script-migration -Context DataContext -Project KevArt.Database
	script-migration -Context DataContextSqlite -Project KevArt.Database


4) Remove Last Migration
	remove-migration -Context DataContext -Project KevArt.Database
	remove-migration -Context DataContextSqlite -Project KevArt.Database


5) Drop Database
	Drop-Database -Context DataContext -Project KevArt.Database
	Drop-Database -Context DataContextSqlite -Project KevArt.Database