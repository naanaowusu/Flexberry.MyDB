import EditFormController from 'ember-flexberry/controllers/edit-form';

export default EditFormController.extend({
  parentRoute: 'i-i-s-my-d-b-class-meeting-l',

  getCellComponent(attr, bindingPath, model) {
    let cellComponent = this._super(...arguments);
    if (attr.kind === 'belongsTo') {
      switch (`${model.modelName}+${bindingPath}`) {
        case 'i-i-s-my-d-b-presntation+book':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'name',
            required: true,
            relationName: 'book',
            projection: 'BookL',
            autocomplete: true,
          };
          break;

        case 'i-i-s-my-d-b-presntation+speaker':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'firstName',
            required: true,
            relationName: 'speaker',
            projection: 'SpeakerL',
            autocomplete: true,
          };
          break;

      }
    }

    return cellComponent;
  },
});
