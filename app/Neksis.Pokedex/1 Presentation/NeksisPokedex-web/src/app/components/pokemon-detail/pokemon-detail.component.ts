import { AfterViewInit, Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { pokemonResult } from 'src/app/agents/pokemon.result';
import { PokemonService } from 'src/app/services/pokemon.service';

@Component({
  selector: 'app-pokemon-detail',
  templateUrl: './pokemon-detail.component.html',
  styleUrls: ['./pokemon-detail.component.scss']
})
export class PokemonDetailComponent implements OnInit {

  idPokemon!: number;
  pokemon!: pokemonResult;

  constructor(
    private route: ActivatedRoute,
    private pokemonService: PokemonService) {
  }
  // ngAfterViewInit(): void {
  //   this.findPokemon();
  // }

  ngOnInit(): void {
    this.idPokemon = this.route.snapshot.params.id;
    if (this.idPokemon) {
      this.findPokemon();
    }
  }

  findPokemon() {
    this.pokemonService.FindPokemon(this.idPokemon).subscribe((response) => {
      this.pokemon = response;
      console.log(this.pokemon)
    })
  }
}
