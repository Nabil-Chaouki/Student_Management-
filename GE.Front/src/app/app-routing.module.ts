import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListEtudiantComponent } from './list-etudiant/list-etudiant.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
  path:'etudiant',
  component:ListEtudiantComponent,
  pathMatch:'full'
},
];

@NgModule({
  imports: [RouterModule.forRoot(routes), CommonModule],
  exports:[RouterModule]
})
export class AppRoutingModule { }
