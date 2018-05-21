namespace MultiTenancy.Admninistration {
    export interface TenantsRow {
        TenantId?: number;
        TenantName?: string;
    }

    export namespace TenantsRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'TenantName';
        export const localTextPrefix = 'Admninistration.Tenants';
        export const lookupKey = 'Administration.Tenant';

        export function getLookup(): Q.Lookup<TenantsRow> {
            return Q.getLookup<TenantsRow>('Administration.Tenant');
        }

        export declare const enum Fields {
            TenantId = "TenantId",
            TenantName = "TenantName"
        }
    }
}
