test:
	dotnet test --no-build -p:CollectCoverage=true -p:CoverletOutputFormat=lcov -p:CoverletOutput=coverage/

publish:
	make clean && dotnet pack -c Release

clean:
	dotnet clean
csharp:
	rm -rf /docs && \
	rm -rf src/Conekta.net/Model && \
	npx @openapitools/openapi-generator-cli generate \
    -i https://raw.githubusercontent.com/conekta/openapi/main/_build/api.yaml \
    -g csharp \
    -o . \
    -c config-netcore.json \
    --global-property modelTests=false
