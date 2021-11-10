/**-----------------------------------------------------------------------------------------
* Copyright © 2021 Progress Software Corporation. All rights reserved.
* Licensed under commercial license. See LICENSE.md in the project root for more information
*-------------------------------------------------------------------------------------------*/
import * as tslib_1 from "tslib";
import { Component, ChangeDetectionStrategy, Input, Inject, LOCALE_ID } from '@angular/core';
import { IntlService } from '@progress/kendo-angular-intl';
import { CollectionService } from '../common/collection.service';
import { ConfigurationService } from '../common/configuration.service';
import { XAxisItemComponentGenerated } from './x-axis-item.component.generated';
/**
 * The configuration component for an X axis
 * ([see example]({% slug api_charts_xaxiscomponent %})).
 */
var XAxisItemComponent = /** @class */ (function (_super) {
    tslib_1.__extends(XAxisItemComponent, _super);
    function XAxisItemComponent(configurationService, collectionService, intl, localeId) {
        var _this = _super.call(this, configurationService, collectionService, intl, localeId) || this;
        _this.configurationService = configurationService;
        _this.collectionService = collectionService;
        _this.intl = intl;
        return _this;
    }
    tslib_1.__decorate([
        Input(),
        tslib_1.__metadata("design:type", Array)
    ], XAxisItemComponent.prototype, "categories", void 0);
    XAxisItemComponent = tslib_1.__decorate([
        Component({
            changeDetection: ChangeDetectionStrategy.OnPush,
            providers: [ConfigurationService],
            selector: 'kendo-chart-x-axis-item',
            template: ''
        }),
        tslib_1.__param(3, Inject(LOCALE_ID)),
        tslib_1.__metadata("design:paramtypes", [ConfigurationService,
            CollectionService,
            IntlService, String])
    ], XAxisItemComponent);
    return XAxisItemComponent;
}(XAxisItemComponentGenerated));
export { XAxisItemComponent };
