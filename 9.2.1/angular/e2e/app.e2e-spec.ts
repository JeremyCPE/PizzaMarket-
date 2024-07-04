import { PizzaMarketTemplatePage } from './app.po';

describe('PizzaMarket App', function() {
  let page: PizzaMarketTemplatePage;

  beforeEach(() => {
    page = new PizzaMarketTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
