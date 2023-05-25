test:
	dotnet test --no-build -p:CollectCoverage=true -p:CoverletOutputFormat=lcov -p:CoverletOutput=coverage/

publish:
	make clean && dotnet pack -c Release

clean:
	dotnet clean