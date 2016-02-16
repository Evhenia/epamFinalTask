app.service('testApi', function (Restangular) {

    //var httpSource = Restangular.all('contacts');
    //https://github.com/mgonto/restangular
    this.load = function () {
        return Restangular.all('api').all('theme').getList();
    };

    this.create = function (contact) {
        //return httpSource.post(contact);
    };

    this.update = function (contactId, contact) {
        //return httpSource.customPUT(contact);
    };

    this.remove = function (contactId) {
        //return Restangular.one('contacts', contactId).remove();
    }

});