import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { pokemonResponse, pokemonResult } from '../agents/pokemon.result';

@Injectable({
  providedIn: 'root'
})
export class PokemonService {
  urlPokemon: string

  constructor(private httpclient: HttpClient) {
    this.urlPokemon = environment.urlPokemon;
  }

  ListPokemon(): Observable<pokemonResult[]> {
    return this.httpclient.get<pokemonResult[]>(`${this.urlPokemon}Pokemon/Get`);
    // .pipe(map((response: pokemonResponse) => {
    //   return response;
    // }));
  }

  FindPokemon(request: number): Observable<pokemonResult>{
    return this.httpclient.get<pokemonResult>(`${this.urlPokemon}Pokemon/FindPokemon/${request}`);
  }
}
