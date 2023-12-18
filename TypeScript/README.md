# jhoney's TypeScript notes #
* [Main Notes](../README.md#quick-links)

### install ###
* npm install -g typescript

### Quick Links ###
* [Home](../README.md)
* [Local CLI app set up](#js_local_cli_set_up)
* [ts-node CLI Commands](#ts-node_cli_commands)
* [npm CLI Commands](#npm_cli_commands)

### Local CLI app set up ###
* using local file 
    - be sure to "type": "module" to package.json
    - I tend to use import style like this
        - import {PrintTo255_For} from "./BasicAlgorithms/PrintTo255.js"


<a name="js_local_cli_set_up"></a>

### ts-node CLI Commands ###
* tsc <filename> --compiles a ts file to js
* ts-node .   --runs a project from a package.json
* ts-node <fileName> -- runs a specific file
<a name="ts-node_cli_commands"></a>

### Node CLI Commands ###
* npm init   --creats a project with a package.json
<a name="npm_cli_commands"></a>