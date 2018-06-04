import { LearningABPTemplatePage } from './app.po';

describe('LearningABP App', function() {
  let page: LearningABPTemplatePage;

  beforeEach(() => {
    page = new LearningABPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
