export class pokemonResponse {
  result: pokemonResult;
  /**
   *
   */
  constructor() {
    this.result = new pokemonResult();

  }
}

export class pokemonResult {
  id!: string;
  image!: string;
  idImage!: string;
  type: string[];
  name!: pokemonNameResult;
  base!: pokemonBaseResult;

  constructor() {
    this.type = [];
  }
}
export class pokemonNameResult {
  english!: string;
  japanese!: string;
  chinese!: string;
  french!: string;
}

export class pokemonBaseResult {
  hp!: number;
  attack!: number;
  defense!: number;
  spattack!: number;
  spdefense!: number;
  speed!: number;
}
