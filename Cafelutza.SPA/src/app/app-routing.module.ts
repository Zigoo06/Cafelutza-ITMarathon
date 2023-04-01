import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AnalyzePageComponent } from './analyze-page/analyze-page.component';
import { AnalyzeRaportComponent } from './analyze-raport/analyze-raport.component';
import { HomePageComponent } from './home-page/home-page.component';
import { ReportsComponent } from './reports/reports.component';

const routes: Routes = [
  { path: '', component: HomePageComponent },
  { path: 'reports', component: ReportsComponent },
  { path: 'analyze', component: AnalyzePageComponent },
  { path: 'analyze/:id', component: AnalyzeRaportComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
