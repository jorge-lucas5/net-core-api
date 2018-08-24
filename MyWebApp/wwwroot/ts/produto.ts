export class Produto {
    private _id: number = 0;
    private _nome: string;
    private _descricao: string;
    private _preco: number;
    //constructor(private _descricao: string, private _preco: number) {

    //}

    get id() {
        return this._id;
    }

    set id(id: number) {
        this._id = id;
    }

    get nome() {
        return this._nome;
    }

    set nome(nome: string) {
        this._nome = nome;
    }

    get descricao() {
        return this._descricao;
    }

    set descricao(descricao: string) {
        this._descricao = descricao;
    }

    get preco() {
        return this._preco;
    }

    set preco(preco: number) {
        this._preco = preco;
    }
}
