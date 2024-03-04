import { LOCALE_ID, NgModule } from "@angular/core";
import { AppComponent } from "./app.component";
import { BrowserModule } from "@angular/platform-browser";
import { AppRoutingModule } from "./app-routing.module";
import { HttpClientModule } from "@angular/common/http";
import { ComponentsModule } from "./components/components.module";

@NgModule({
    declarations: [AppComponent], 
    imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      ComponentsModule
    ],
    bootstrap: [AppComponent],
    providers: [
      { provide: LOCALE_ID, useValue: 'es-*' }
    ]
  })
export class AppModule {
}
