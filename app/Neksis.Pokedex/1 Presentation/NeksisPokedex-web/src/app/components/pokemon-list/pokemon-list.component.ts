import { Component, OnInit, ViewChild } from '@angular/core';
import { pokemonResult } from 'src/app/agents/pokemon.result';
import { PokemonService } from 'src/app/services/pokemon.service';

@Component({
  selector: 'app-pokemon-list',
  templateUrl: './pokemon-list.component.html',
  styleUrls: ['./pokemon-list.component.scss']
})
export class PokemonListComponent implements OnInit {

  displayedColumns: string[] = ['id', 'name', 'image', 'type'];
  pokemons: pokemonResult[] = [];


  constructor(private pokemonService: PokemonService) {

  }

  ngOnInit(): void {
    this.getPokemons();
  }

  getPokemons() {
    this.pokemonService.ListPokemon().subscribe(
      response => {
        response.forEach(r => {
          this.pokemons.push({
            id: r.id,
            image: r.image,
            idImage: r.idImage,
            name: r.name,
            type: r.type,
            base: r.base
          });
        });
      },
      error => {
        console.log("Error")
      }
    );
  }

}
