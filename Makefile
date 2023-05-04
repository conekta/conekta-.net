test:
	dotnet test

publish:
	make clean && dotnet pack -c Release

clean:
	dotnet clean