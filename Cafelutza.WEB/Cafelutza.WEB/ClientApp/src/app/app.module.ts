import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatInputModule } from '@angular/material/input';
import { ReportsComponent } from './reports/reports.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { ReactiveFormsModule } from '@angular/forms';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { AnalyzePageComponent } from './analyze-page/analyze-page.component';
import { MatCardModule } from '@angular/material/card';
import { AnalyzeRaportComponent } from './analyze-raport/analyze-raport.component';
import { HomePageComponent } from './home-page/home-page.component';
import { HttpClientModule } from '@angular/common/http';
import { RaportService } from './services/raport.service';
import { UserService } from './services/user.service';
import { RoleGuard } from './guard/role.guard';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    ReportsComponent,
    AnalyzePageComponent,
    AnalyzeRaportComponent,
    HomePageComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatSelectModule,
    MatInputModule,
    MatButtonModule,
    ReactiveFormsModule,
    LayoutModule,
    MatToolbarModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    HttpClientModule,
  ],
  providers: [RaportService, UserService, RoleGuard],
  bootstrap: [AppComponent],
})
export class AppModule {}
